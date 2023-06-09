var hashtagInput = document.getElementById("hashtagInput");
var hashtagRawText = document.getElementById("hashtagRawText");
var searchquery = document.getElementById("searchquery");

var topics = [];
var hashtags = [];
var proglangs = [];

var firstQuery = '';

searchquery.addEventListener("focusin", event => {
    let searchqueryhelper = document.getElementById("searchqueryhelper");
    searchqueryhelper.style.opacity = 100;

    if (topics.length == 0 && hashtags.length == 0)
        getQueryData();
});
searchquery.onkeydown = event => {
    if (event.key == 'Tab')
        searchquery.value = firstQuery;
};
searchquery.addEventListener("input", event => {
    const inputText = searchquery.value.toLowerCase();

    const autocompleteList = document.getElementById('autocompletelist');
    autocompleteList.innerHTML = '';

    let matches = [];

    if (inputText.includes('hashtag:')) {
        const val = inputText.replace('hashtag:', '');
        matches = hashtags.filter(h => h.toLowerCase().startsWith(val));
    }
    else if (inputText.includes('proglang:')) {
        const val = inputText.replace('proglang:', '');
        matches = proglangs.filter(p => p.toLowerCase().startsWith(val));
    }
    else {
        let val = inputText;
        if (inputText.includes('title:'))
            val = inputText.replace('title:', '');
        matches = topics.filter(t => t.toLowerCase().startsWith(val));
    }
    let i = 0;
    matches.forEach(m => {
        const li = document.createElement('li')
        if (i == 0) {
            firstQuery = m;
            li.classList.add('active');
        }
        li.classList.add('list-group-item');
        li.classList.add('list-group-item-action');
        li.classList.add('searchquery-item');
        li.textContent = m;

        li.onclick = () => {
            searchquery.value = m;
        };
        autocompleteList.appendChild(li);
        i++;
    });
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

async function getQueryData() {
    const tResponse = await fetch(window.location.origin + '/TopicRepository');

    if (tResponse.ok) {
        let data = await tResponse.json();

        data.forEach(d => {
            topics.push(d.title);
        });
    }
    else {
        console.log("Can't fetch topics!");
    }

    const hResponse = await fetch(window.location.origin + '/HashtagRepository');
    if (hResponse.ok) {
        hashtags = await hResponse.json();
    }
    else {
        console.log("Can't fetch hashtags!");
    }

    const pResponse = await fetch(window.location.origin + '/ProgLangRepository');
    if (pResponse.ok) {
        proglangs = await pResponse.json();
    }
    else {
        console.log("Can't fetch hashtags!");
    }
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

    if (btn.classList.includes("btn-outline-primary")) {
        input.value += btn.value + ';';
        btn.classList.replace("btn-outline-primary", "btn-primary");
    }
    else {
        btn.classList.replace("btn-primary", "btn-outline-primary");
        input.value = input.value.replace(btn.value + ';', '');
    }
}