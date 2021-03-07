$(function () {
    var l = abp.localization.getResource('KullaniciStore');

    // JS 

    var createModal = new abp.ModalManager(abp.appPath + 'Kullaniciler/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Kullaniciler/EditModal');

    var dataTable = $('#KullanicilerTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(acme.firstAbp.kullaniciler.kullanici.getList),
            columnDefs: [
                {
                    title: l('Actions'),
                    rowAction: {
                        items:

                            [
                                {
                                    //Kullanici Güncelleme
                                    text: l('Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    // Kullanici Silme
                                    text: l('Delete'),
                                    confirmMessage: function (data) {
                                        return l('KullaniciDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        acme.firstAbp.kullaniciler.kullanici
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(l('SuccessfullyDeleted'));
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
               

                {
                    title: l('Name'),
                    data: "name"
                },
               /* {
                    title: l('Type'),
                    data: "type",
                    render: function (data) {
                        return l('Enum:KullaniciType:' + data);
                    }
                },*/
                {
                    title: l('Surname'),
                    data: "surname"
                },
                {
                    title: l('Num'),
                    data: "num"
                },
                {
                    title: l('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    // NewKullanici Butonu
    $('#NewKullaniciButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });

});
