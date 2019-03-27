var dataObject =  {
    searchText: "",
    searchTextWithinTitle:"",
    items: [] = []
};

var app = new Vue({
    el: '#mainApp',
    data: dataObject,
    methods: {
        search(event) {            
            if (event.code === 'Enter' || event.code === 'NumpadEnter') {
                window.location.href = `${baseUrl}/movies/search/${this.$data.searchText}`;
            }
        },
        searchWithinTitle(event) {
            if (event.code === 'Enter' || event.code === 'NumpadEnter') {
                console.log(this.$data.searchTextWithinTitle);
            }
        }
    }
});