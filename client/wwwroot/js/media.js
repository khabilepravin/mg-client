//var app = new Vue({
//    el: '#media',
//    data: {
//        name: "Test",
//        description: "desc",
//        season: 1,
//        episode: 1,
//        keywords: "rwsf",
//        externalLink: "fdsf",
//        releaseDate: 1990,
//        filesubtitleFile: ''
//    },
//    methods: {
//        submitMedia() {
//            const formData = new FormData();
//            formData.append(name, this.$data.filesubtitleFile, this.$data.filesubtitleFile.name);

//            axios.post(`${baseUrl}/media/postmedia`, this.$data, {
//                headers: {
//                    'Content-Type': 'multipart/form-data'
//                }
//            })
//                .then(function (response) {
//                    console.log(response.data);
//                })
//                .catch(function (error) {
//                    console.log(error.response);
//                });
//        },
//        handleFileUpload(name, files) {
//            if (!files.length)
//                return;

//            this.filesubtitleFile = files[0];
//            console.log(this.filesubtitleFile);
//        }
//    }
//});