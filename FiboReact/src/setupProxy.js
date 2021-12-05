const { createProxyMiddleware } = require('http-proxy-middleware');

module.exports = function(app) {
  app.use(
    '/fibonacci',
    createProxyMiddleware({
      target: 'http://168.138.176.212:8000',
      changeOrigin: true,
    })
  );
};