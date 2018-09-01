export class CreateCommentModel {
    constructor(
        public comment: string,
        public postId: string,
        public author: string,
    ) { }
}