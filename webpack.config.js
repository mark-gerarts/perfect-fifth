// Note this only includes basic configuration for development mode.
// For a more comprehensive configuration check:
// https://github.com/fable-compiler/webpack-config-template

const path = require("path");
const TerserPlugin = require("terser-webpack-plugin");

module.exports = {
    mode: "development",
    entry: "./src/PerfectFifth.Site/App.fs.js",
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
    module: {},
    optimization: {
        minimize: true,
        minimizer: [
            new TerserPlugin({
                test: /\.js$/i,
            })
        ],
    }
}
