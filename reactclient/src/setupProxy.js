const { createProxyMiddleware } = require('http-proxy-middleware');

const context = [
    "/weatherforecast",
];

module.exports = function (app) {
    const appProxy = createProxyMiddleware(context, {
        target: process.env.WEB_API_BASE_URL,
        secure: false
    });

    app.use(appProxy);
};
