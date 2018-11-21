var app = new Vue({
    el: '#app',
    watch: {},
    data: {
        timeTableData: {
            metros: []
        }
    },
    methods: {
        getTimeTable() {
            axios.get(
                "/api/sl/GetTimeTable/"
            ).then((response) => {
                var responseJson = JSON.parse(response.data);
                this.timeTableData.metros = responseJson.ResponseData.Metros;
            }).catch(() => {

            });
        }
    },
    created() {
        var timeTableRequestData = this.getTimeTable();
        Object.assign(this.timeTableData, timeTableRequestData);
    }
});