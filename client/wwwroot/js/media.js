var app = new Vue({
    el: '#media',
    data: {
        name: "Test",
        description: "desc",
        season: 1,
        episode: 1,
        keywords: "rwsf",
        externalLink:"fdsf",
        releaseDate: 1990,
        file:""
    },
    methods: {
        submitMedia: function () {
            alert('Hello');
        }
    }
});