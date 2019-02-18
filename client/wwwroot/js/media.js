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
        filesubtitleFile: File
    },
    methods: {
        submitMedia() {
            axios.post(`${baseUrl}/media/postmedia`, this.$data)
                .then(function (response) {
                    console.log(response.data);
                })
                .catch(function (error) {
                    console.log(error.response);
                });
        },
        handleFileUpload(name, files) {
            //var files = e.target.files || e.dataTransfer.files;
            const formData = new FormData();

            if (!files.length)
                return;

            this.filesubtitleFile = files[0];
            formData.append(name, files[0], files[0].name);
            console.log(this.filesubtitleFile);
        }
    }
});