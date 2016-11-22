
(function () {
    var form = document.getElementById("CommentFormID");
    form.addEventListener("submit", function (e) {
        


        var txtbox = document.getElementById("content");
        
        if (txtbox.value === "") {
            txtbox.className = "RedBorder form-control";
            e.preventDefault();
        }
        else {
            txtbox.className = "form-control";                   
        }
    })
})();