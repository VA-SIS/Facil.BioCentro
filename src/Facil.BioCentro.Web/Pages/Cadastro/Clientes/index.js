$(function () {
    var l = abp.localization.getResource('BioCentro');
    var createModal = new abp.ModalManager(abp.appPath + 'Cadastro/Clientes/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Cadastro/Clientes/EditModal');

    var dataTable = $('#clientesTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            



            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(facil.bioCentro.clientes.cliente.getList),
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
                    title: l('Cpf_Cnpj'),
                    data: "cpf_cnpj"
                },

                {
                    title: l('TipoPessoa'),
                    data: "tipopessoa"
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
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: true
                                        /*abp.auth.isGranted('BioCentro.Clientes.Delete')*/,
                                    confirmMessage: function (data) {
                                        return l(
                                            'ClienteDeletionConfirmationMessage',
                                            data.record.name
                                        );
                                    },
                                    action: function (data) {
                                        facil.bioCentro.clientes.cliente
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

    $('#NovoClienteButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
