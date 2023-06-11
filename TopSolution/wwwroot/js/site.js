var hashtagInput = document.getElementById("hashtagInput");
var hashtagRawText = document.getElementById("hashtagRawText");
var searchquery = document.getElementById("searchquery");
var querysubmitbtn = document.getElementById("querysubmit");

var topics = [];
var hashtags = [];
var proglangs = [];
var profiles = [];

var firstQuery = '';
var queryTag = '';

querysubmitbtn.onclick = event => {
    if (queryTag != '' && queryTag != 'user:')
        window.location.href = window.location.origin + '/Topics?query=' + queryTag + searchquery.value;
    else if (queryTag == 'user:')
        window.location.href = window.location.origin + '/Profile/List?query=' + searchquery.value.replace('user:','');
};
searchquery.addEventListener("focusin", event => {
    let searchqueryhelper = document.getElementById("searchqueryhelper");
    searchqueryhelper.style.display = 'flex';

    if (topics.length == 0 && hashtags.length == 0)
        getQueryData();
});
searchquery.onkeydown = event => {
    if (event.key == 'Tab')
        searchquery.value = firstQuery;
    else if (event.key == 'Enter')
        querysubmitbtn.click();
};
searchquery.addEventListener("input", event => {
    const inputText = searchquery.value.toLowerCase();

    const autocompleteList = document.getElementById('autocompletelist');
    autocompleteList.innerHTML = '';

    let matches = [];

    if (inputText.includes('hashtag:')) {
        const val = inputText.replace('hashtag:', '');
        matches = hashtags.filter(h => h.toLowerCase().startsWith(val)).slice(0, 10);
        queryTag = 'hashtag:';
    }
    else if (inputText.includes('proglang:')) {
        const val = inputText.replace('proglang:', '');
        matches = proglangs.filter(p => p.toLowerCase().startsWith(val)).slice(0, 10);
        queryTag = 'proglang:';
    }
    else if (inputText.includes('user:')) {
        const val = inputText.replace('user:', '');
        matches = profiles.filter(p => p.displayName.toLowerCase().startsWith(val)).slice(0, 10);
        queryTag = 'user:';
    }
    else {
        let val = inputText;
        if (inputText.includes('title:'))
            val = inputText.replace('title:', '');
        matches = topics.filter(t => t.toLowerCase().startsWith(val)).slice(0,10);
        queryTag = 'title:';
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
        if (queryTag == 'user:') {
            li.textContent = m.displayName;
            li.onclick = () => {
                window.location.href = window.location.origin + '/Profile/Index/'+ m.id;
            };
        }
        else {
            li.onclick = () => {
                searchquery.value = m;
                querysubmitbtn.click();
            };
            li.textContent = m;
        }
        
        autocompleteList.appendChild(li);
        i++;
    });
});
searchquery.addEventListener("focusout", event => {
    let searchqueryhelper = document.getElementById("searchqueryhelper");

    setTimeout(() => {
        searchqueryhelper.style.display = 'none';
    },200);
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

    const hResponse = await fetch(window.location.origin + '/api/HashtagRepository');
    if (hResponse.ok) {
        hashtags = await hResponse.json();
    }
    else {
        console.log("Can't fetch hashtags!");
    }

    const profResponse = await fetch(window.location.origin + '/api/ProfileRepository');
    if (profResponse.ok) {
        profiles = await profResponse.json();
    }
    else {
        console.log("Can't fetch profiles!");
    }

    const pResponse = await fetch(window.location.origin + '/api/ProgLangRepository');
    if (pResponse.ok) {
        proglangs = await pResponse.json();
    }
    else {
        console.log("Can't fetch proglangs!");
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