var app = new Vue({
    el: '#mainApp',
    data: {
        searchText:""
    },
    methods: {
        search(event) {            
            if (event.code === 'Enter' || event.code === 'NumpadEnter') {
                console.log(this.$data.searchText);
                axios.get(`${baseUrl}/search/searchmedia?mediaText=${this.$data.searchText}`)
                    .then(function (response) {
                        console.log(response.data);
                    })
                    .catch(function (error) {
                        console.log(error.response);
                    });

            }
        }
    }
});