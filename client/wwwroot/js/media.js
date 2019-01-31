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
        filesubtitleFile:''
    },
    methods: {
        submitMedia() {
            console.log('submit media called');
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