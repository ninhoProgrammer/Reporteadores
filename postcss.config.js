module.exports = {
    plugins: {
        tailwindcss: {},
        autoprefixer: {},
    },
    "scripts": {
      "build:css": "tailwindcss -i ./input.css -o ./wwwroot/css/output.css --watch"
    }
}