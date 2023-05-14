function openTab(e, tabId) {

    var i, tabcontent, tabbtns;

    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }

    tabbtns = document.getElementsByClassName("tabbtn");
    for (i = 0; i < tabbtns.length; i++) {
        tabbtns[i].className = tabbtns[i].className.replace(" active", "");
    }

    document.getElementById(tabId).style.display = "block";
    e.currentTarget.className += " active";
}