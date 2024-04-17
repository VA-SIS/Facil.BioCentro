$(function () {
    var l = abp.localization.getResource('BioCentro');
    var createModal = new abp.ModalManager(abp.appPath + 'Cadastro/Servicos/CreateModalServico');
    var editModal = new abp.ModalManager(abp.appPath + 'Cadastro/Servicos/EditModalServico');

    var dataTable = $('#servicosTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            



            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(facil.bioCentro.servicos.servico.getList),
            columnDefs: [
                
                {
                    title: l('Descricao'),
                    data: "descricao"
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
                                            'ServicoDeletionConfirmationMessage',
                                            data.record.descricao
                                        );
                                    },
                                    action: function (data) {
                                        facil.bioCentro.servicos.servico
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

    $('#NovoServicoButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
