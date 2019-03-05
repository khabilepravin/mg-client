var dataObject =  {
    searchText: "",
    items: [] = []
};

var app = new Vue({
    el: '#mainApp',
    data: dataObject,
    methods: {
        search(event) {            
            if (event.code === 'Enter' || event.code === 'NumpadEnter') {
               // console.log(this.data.searchText);
                axios.get(`${baseUrl}/search/searchmedia?mediaText=${this.$data.searchText}`)
                    .then(function (response) {
                        app.$data.items = response.data;
                    })
                    .catch(function (error) {
                        console.log(error.response);
                    });

            }
        }
    }
});