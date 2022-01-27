import dashboard from "./views/dashboard.js";
import postsview from "./views/postsview.js";
import settings from "./views/settings.js";

const navigateTo = function (url) {
    history.pushState(null, null, url);
    router();
}

const router = async function () {
    const routes = [
        {path: "/", view: dashboard},
        {path: "/posts", view: postsview},
        {path: "/settings", view: settings},
        // { path: "/", view: function () { console.log("Viewing Dashboard") } },
        // { path: "/posts", view: function () { console.log("Viewing Posts") } },
        // { path: "/settings", view: function () { console.log("Viewing Settings") } },
    ];

    //Test each route for potential match
    const potentialMatches = routes.map(function (route) {
        return {
            route: route,
            isMatch: location.pathname === route.path
        };
    });

    //Find a match
    let match = potentialMatches.find(p => p.isMatch);

    if (!match) {
        match = {
            route: routes[0],
            isMatch: true
        };
    }
    const view = new match.route.view();
    document.querySelector("#app").innerHTML = await view.getHtml();
    // console.log(potentialMatches);

    //console.log(match.route.view());
};

window.addEventListener("popstate", router);

document.addEventListener("DOMContentLoaded", function () {
    document.body.addEventListener("click", function (e) {
        if (e.target.matches("[data-link]")) {
            e.preventDefault();
            navigateTo(e.target.href);
        }
    });
    router();
});