export class CreatePostModel {
    constructor(
        public map: string,
        public title: string,
        public description: string,
        public image: string,
        public author: string,
    ) { }
}