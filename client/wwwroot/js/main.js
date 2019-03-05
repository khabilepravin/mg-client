var app = new Vue({
    el: '#mainApp',
    data: {
        searchText:""
    },
    methods: {
        search(event) {            
            if (event.code == 'Enter' || event.code == 'NumpadEnter') {
                console.log(this.$data.searchText);
            }
        }
    }
});