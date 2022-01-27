import abstractview from "./abstractview.js";

export default class extends abstractview{
    constructor() {
        super();
        this.setTitle("Dashboard");
    }

    async getHtml() {
        return `
        <h1>Welcome Jean-Joseph</h1>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis fuga eius non itaque hic est odit quis, culpa praesentium saepe, repellat quo dignissimos placeat alias.</p>
        <p>
            <a href="/posts" data-links>View Recent Posts</a>
        </p>
        `;
    }
}