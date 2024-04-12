$(function () {
    var l = abp.localization.getResource('BioCentro');
    var createModal = new abp.ModalManager(abp.appPath + 'Cadastro/Profissionais/CreateModalProfissional');
    var editModal = new abp.ModalManager(abp.appPath + 'Cadastro/Profissionais/EditModalProfissional');

    var dataTable = $('#profissionaisTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({            
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(facil.bioCentro.profissionais.profissional.getList),
            columnDefs: [
               
                {
                    title: l('Nome'),
                    data: "nome"
                },
                {
                    title: l('Email'),
                    data: "email"
                },

                {
                    title: l('Profissao'),
                    data: "profissao"
                },

                {
                    title: l('TipoPessoa'),
                    data: "tipoPessoa"
                },

                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: true
                                        /*abp.auth.isGranted('BioCentro.Clientes.Edit')*/,
                                    action: function (data) {
                                        console.log("Edit -> "+data.record.id);
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: true
                                        /*abp.auth.isGranted('BioCentro.Clientes.Delete')*/,
                                    confirmMessage: function (data) {
                                       
                                        return l(
                                            'ProfissionalDeletionConfirmationMessage',
                                            data.record.name
                                        );
                                    },
                                    action: function (data) {
                                       
                                        facil.bioCentro.profissionais.profisional
                                            .delete(data.record.id)
                                            .then(function () {
                                               
                                                abp.notify.info(
                                                    l('SuccessfullyDeleted')
                                                );
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
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

    $('#NovoProfissionalButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
