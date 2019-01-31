var app = new Vue({
    el: '#media',
    data: {
        name: "Test",
        description: "desc",
        season: 1,
        episode: 1,
        keywords: "rwsf",
        externalLink: "fdsf",
        releaseDate: 1990,
        filesubtitleFile: ''
    },
    methods: {
        submitMedia() {
            axios.post('media/postmedia', { body: this })
                .then(function (response) {
                    console.log(response.data);
                })
                .catch(function (error) {
                    console.log(error.response);
                });
        },
        handleFileUpload(e) {
            console.log('this gets called at least');
            var files = e.target.files || e.dataTransfer.files;

            if (!files.length)
                return;

            this.filesubtitleFile = files[0];
            console.log(this.filesubtitleFile);
        }
    }
});