///<reference path="jquery.js" />
const firstNameElement = $("#firstName");
function formValidation() {
    let firstNameValue = firstNameElement.val()
    if (firstNameValue !== "test") {
        
        alert("Name should be test");
        return false;
    }
}