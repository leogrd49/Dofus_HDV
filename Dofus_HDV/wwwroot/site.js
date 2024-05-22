window.initializeDataTable = () => {
    $(document).ready(function () {
        $('#mydatatable').DataTable({
            "paging": false,
            "info": false,
            "searching": true
        });
    });
};