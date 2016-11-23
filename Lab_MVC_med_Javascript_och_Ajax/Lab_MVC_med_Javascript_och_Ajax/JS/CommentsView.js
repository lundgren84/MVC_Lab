
(function () {
    var form = document.getElementById("CommentFormID");
    form.addEventListener("submit", function (e) {
        


        var txtbox = document.getElementById("content");
        
        if (txtbox.value === "") {
            e.preventDefault();
            txtbox.className = "RedBorder form-control";
            $.growl({ title: "Growl", message: "The kitten is awake!" });
            $.growl.error({ message: "Enter comment!" });            
        }
        else {
            txtbox.className = "form-control";
            $.growl.notice({ message: "Comment added!" });
        }
    })
})();

