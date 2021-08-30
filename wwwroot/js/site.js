// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// only send 1 file for now
function sendFiles(files, id) {
    data = new FormData();
    data.append("file", files[0]);

    $.ajax({
        data: data,
        type: "POST",
        url: "/api/article",
        cache: false,
        contentType: false,
        processData: false,
        success: function (imgUrl) {
            imgNode = $("<img src='" + imgUrl + "'>");

            $(id).summernote('insertNode', imgNode[0]);
        }
    });
}

function deleteFile(fileName) {
    data = new FormData();
    data.append("fileName", fileName);

    $.ajax({
        data: data,
        type: "DELETE",
        url: "/api/article",
        cache: false,
        contentType: false,
        processData: false,
        success: function (fileName) {
            alert("Image named " + fileName + " deleted from server!"); //for now. DELETE when everything done
        }
    });
}


