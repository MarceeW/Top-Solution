var hashtagInput = document.getElementById("hashtagInput");
var hashtagRawText = document.getElementById("hashtagRawText");

document.getElementById("hashtagInput").addEventListener("keydown", event => {
    if (event.code === "Space") {
        if (hashtagInput.value.length > 0 && hashtagInput.value != ' ' && !hashtagRawText.value.includes(hashtagInput.value)) {
            let text = '';

            if (hashtagInput.value.includes("#"))
                text += hashtagInput.value;
            else
                text += '#' + hashtagInput.value;

            hashtagRawText.value += text;

            let hashtagContainer = document.getElementById("hashtagContainer");
            let elementId = "hst" + text;
            let tagElement =
                '<span class="me-sm-1" id="' + elementId +'">'+
                    '<span class="badge bg-secondary"> ' +
                        '<span class="">' + text +'</span>' +
                        '<button type="button" class="badge btn" onclick="removeHashtag(this,\''+ text +'\',hashtagRawText)">x</button>' +
                    '</span > ' +
                '</span >';

            hashtagContainer.innerHTML += tagElement;
        }
    }
});
document.getElementById("hashtagInput").addEventListener("keyup", event => {
    if (event.code === "Space")
        hashtagInput.value = '';
});
function removeHashtag(btn,textToRemove,inputIdToRemove) {
    let input = document.getElementById(inputIdToRemove.id);
    let toDelete = btn.parentNode.parentNode;

    input.value = input.value.replace(textToRemove, '');
    toDelete.remove();
}

function proglangButtonClick(id, inputIdToAdd) {
    let input = document.getElementById(inputIdToAdd.id);
    let btn = document.getElementById(id);

    if (btn.classList.contains("btn-outline-primary")) {
        input.value += btn.value + ';';
        btn.classList.replace("btn-outline-primary", "btn-primary");
    }
    else {
        btn.classList.replace("btn-primary", "btn-outline-primary");
        input.value = input.value.replace(btn.value + ';', '');
    }
}