var dataObject =  {
    searchText: "",
    searchTextWithinTitle: "",
    searchWithinTitleResult:[],
    items: [] = [],
    selectedMediaId: ""
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
                var id = this.getMediaId();
                axios.get(`${baseUrl}/movies/search/${id}/${this.$data.searchTextWithinTitle}`).then(({ data }) => {
                    this.$data.searchWithinTitleResult = data;
                    console.log(this.$data.searchWithinTitleResult);
                });
            }
        },
        getMediaId() {
            let urlParts = window.location.href.split('/');
            return urlParts[4];
        },
        addToFavorites(title) {
            var userId = localStorage.getItem('mgUserId');
            if (userId !== null && userId !== undefined) {
                if (title.isPartofFavorite === false)
                {
                    axios.post(`${baseUrl}/favorites/add`, { userId: userId, parsedTextId: title.id });
                    title.isPartofFavorite = true;
                }
            }
        }
    }
});