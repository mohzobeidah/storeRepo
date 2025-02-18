$(function () {
    var l = abp.localization.getResource('StoreManagement');
    var createModal = new abp.ModalManager(abp.appPath + 'categories/CreateModal');
    createModal.onOpen(function (modal) {
        modal.find('[name="HiddenProperty"]').closest('.form-group').hide(); // Hide the field
    });
    var editModal = new abp.ModalManager(abp.appPath + 'categories/EditModal');

    var dataTable = $('#BooksTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(mOZ.storeManagement.categories.category.getList),
            columnDefs: [
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('StoreManagement.Books.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('StoreManagement.Books.Delete'),
                                    confirmMessage: function (data) {
                                        return l('BookDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        mOZ.storeManagement.books.book
                                            .delete(data.record.id)
                                            .then(function() {
                                                abp.notify.info(l('SuccessfullyDeleted'));
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
                {
                    title: l('Category:Name'),
                    data: "name"
                }, 
                {
                    title: l('Category:Description'),
                    data: "description"
                },
               
            ]
        })
    );

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewBookButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
