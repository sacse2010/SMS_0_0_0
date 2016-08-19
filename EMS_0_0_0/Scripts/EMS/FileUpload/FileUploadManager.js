
$(document).ready(function() {
    FileUploadHelper.UploadFile();

  
});




var FileUploadManager = {

};

var FileUploadHelper = {
    UploadFile: function () {
        $("#file").fileinput({
            uploadUrl: "../Profile/UploadImage/",
            language: "en",
            allowedFileExtensions: ["jpg", "png", "gif"],
            showUpload: true,
            showRemove: true,
            maxFileSize: 7000,
            maxFileCount: 5,
         
            initialPreviewAsData: true,
            overwriteInitial: false,
        });
    },

   

};