const realBtn = document.getElementById("real-button");
const customBtn = document.getElementById("custom-button");
const customTxt = document.getElementById("custom-text");

customBtn.addEventListener("click", function () {
    realBtn.click();
});

realBtn.addEventListener("change", function () {
    if (realBtn.value) {
        customTxt.innerHTML = realBtn.value.substring(12);
    }
    else {
        customTxt.innerHTML = "No file has been chosen.";
    }
});