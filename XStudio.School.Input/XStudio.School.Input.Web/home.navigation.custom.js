$(function () {
    $(".subtab-navigator-link").click(function () {
        var url = $(this).attr("src");
        var response = $.ajax({ url: url, async: false });
        $("#main-content").html(response.responseText);
    });
});
