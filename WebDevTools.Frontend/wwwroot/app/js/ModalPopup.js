function showModalPopup(showForMs = null) {
    var modalPopup = new bootstrap.Modal(document.getElementById('modalPopupComponent'));

    modalPopup.show();

    if (showForMs) {
        setTimeout(() => {
            modalPopup.hide();
        }, showForMs)
    }
}