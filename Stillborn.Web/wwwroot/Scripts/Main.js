//#region Main
var mainUrl = "";

function Ajax(urlAppend, type, success, data, error) {
    $.Ajax({
        url: mainUrl + urlAppend,
        type: type,
        data: data,
        success: success,
        error: error
    });
}
//#endregion

//#region UserProfile
function DrawUserProfile(user) {
}
//#endregion