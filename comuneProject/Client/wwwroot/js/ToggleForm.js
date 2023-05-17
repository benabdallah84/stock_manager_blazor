window.ToggleForm = (element, IsDisabled) => {
    const divToDisable = document.querySelector(element);
    var nodes = divToDisable.getElementsByTagName('*');
    if (IsDisabled) {

        //$(document).ready(function () {
        //    $(divToDisable).children().prop('disabled', true);
        //});
        for (var i = 0; i < nodes.length; i++) {
            nodes[i].disabled = true;
        }
    }
    else {

        //$(document).ready(function () {
        //    $(divToDisable).children().prop('disabled', false);
        //});
        for (var i = 0; i < nodes.length; i++) {

            nodes[i].disabled = false;
        }
    }
    //if (IsDisabled === 'undefined') {
    //    console.log("IsDisabled is undefined" + " " + guidElement);
    //    element.setguidElement
    //}
    //else {
        
    //    IsDisabled = null;
    //}

    //if (guidElement != 00000000 - 0000 - 0000 - 0000 - 000000000000) { }
}
window.setGuidToForm = (element, guidElement) => {
    const label = document.querySelector(element);
    console.log(label);
    label.value =guidElement;
}
//export setElementText1 = (element, text) => element.innerText = text;