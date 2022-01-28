import abstractview from "./abstractview.js";


export default class extends abstractview{
    constructor(params) {
        super(params);
        this.setTitle("Posts");
    }

    async getHtml() {
        return `
        <h1>All Post Here </h1>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis fuga eius non itaque hic est odit quis, culpa praesentium saepe, repellat quo dignissimos placeat alias.</p>
        <p>
            <a href="/posts" data-links>View other things</a>
        </p>
        `;
    }
}