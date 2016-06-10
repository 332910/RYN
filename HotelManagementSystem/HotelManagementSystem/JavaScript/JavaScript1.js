function ConfirmDelete() {
    var Delet_Confirm = confirm("Do you really want to delete this record ?");
    if (Delet_Confirm == true) {
        return true;
    }
    else {
        return false;
    }
}