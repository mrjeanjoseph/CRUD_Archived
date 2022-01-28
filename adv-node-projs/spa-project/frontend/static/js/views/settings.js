import abstractview from "./abstractview.js";


export default class extends abstractview{
    constructor(params) {
        super(params);
        this.setTitle("Settings");
    }

    async getHtml() {
        return `
        <h1>Settings</h1>
        <p>All about the settings for this software</p>
        <p>
            <a href="/posts" data-links>View other things</a>
        </p>
        `;
    }
}