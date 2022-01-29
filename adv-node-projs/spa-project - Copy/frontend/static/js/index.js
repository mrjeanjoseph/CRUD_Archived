import dashboard from './views/dashboard.js';
import postsview from './views/postsview.js';
import settingsview from './views/settingsview.js';

const navigateTo = function (url) {
    history.pushState(null, null, url);
    router();
}

const router = async function () {
    const routes = [
        {path: "/", view: dashboard},
        {path: "/posts", view: postsview},
        {path: "/settings", view: settingsview},
    ];

    //Test each route for potential match
    const potentialMatches = routes.map(function (route) {
        return {
            route: route,
            isMatch: location.pathname === route.path
        };
    });

    let match = potentialMatches.find(potentialMatch => potentialMatch.isMatch);

    //If not aviable, then default to root display
    if (!match) {
        match = {
            route: routes[0],
            isMatch: true
        }
    }

    // console.log(potentialMatches);
    // console.log(match.route.view());

    const view = new match.route.view();

    document.querySelector("#app").innerHTML = await view.getHtml();
};
window.addEventListener("popstate", router);

document.addEventListener("DOMContentLoaded", function () {
    document.body.addEventListener("click", function (event) {
        if (event.target.matches("[data-link]")) {
            event.preventDefault();
            navigateTo(event.target.href);
        }
    });
    router();
});