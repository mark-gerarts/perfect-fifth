// Note this only includes basic configuration for development mode.
// For a more comprehensive configuration check:
// https://github.com/fable-compiler/webpack-config-template

var path = require("path");

module.exports = {
    mode: "development",
    entry: "./src/PerfectFifth.Examples/App.fs.js",
    output: {
        path: path.join(__dirname, "./public"),
        filename: "bundle.js",
        libraryTarget: 'var',
        library: 'PerfectFifth'
    },
    devServer: {
        static: {
            directory: path.resolve(__dirname, "./public"),
            publicPath: "/",
        },
        port: 8080,
    },
    module: {}
}
