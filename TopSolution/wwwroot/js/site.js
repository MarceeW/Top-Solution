var hashtagInput = document.getElementById("hashtagInput");
var hashtagRawText = document.getElementById("hashtagRawText");
var searchquery = document.getElementById("searchquery");

searchquery.addEventListener("focusin", event => {
    let searchqueryhelper = document.getElementById("searchqueryhelper");
    searchqueryhelper.style.opacity = 100;
});
searchquery.addEventListener("focusout", event => {
    let searchqueryhelper = document.getElementById("searchqueryhelper");
    searchqueryhelper.style.opacity = 0;
});

if (hashtagInput != null) {
    hashtagInput.addEventListener("keydown", event => {
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
                    '<span class="me-sm-1" id="' + elementId + '">' +
                    '<span style="opacity: 0.5;" class="text-light rounded bg-secondary p-sm-2"> ' +
                    '<span style="font-size: 16px;" class="ms-2 me-2">' + text + '</span>' +
                    '<button type="button" class="pb-2 btn-close" aria-label="Close" onclick="removeHashtag(this,\'' + text + '\',hashtagRawText)"></button>' +
                    '</span > ' +
                    '</span >';

                hashtagContainer.innerHTML += tagElement;
            }
        }
    });
    hashtagInput.addEventListener("keyup", event => {
        if (event.code === "Space")
            hashtagInput.value = '';
    });
}

var profUploader = document.getElementById("profilePictureUpload");

if (profUploader != null) {
    profUploader.addEventListener("change", e => {
        document.getElementById("profUploadFormSubmit").click();
    });
}

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