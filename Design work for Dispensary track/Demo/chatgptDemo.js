// app.js

$(document).ready(function () {
    // Load initial page content
    loadPage('demo.html');

    // Attach event listeners to navbar links
    $('.nav-link').on('click', function (event) {
        event.preventDefault();
        const pageUrl = $(this).attr('href');
        loadPage(pageUrl);
    });
});

function loadPage(url) {
    // Use AJAX or fetch request to load page content
    $.ajax({
        url: url,
        success: function (response) {
            $('#page-content').html(response);
        },
        error: function () {
            $('#page-content').html('Error loading page.');
        }
    });
}
