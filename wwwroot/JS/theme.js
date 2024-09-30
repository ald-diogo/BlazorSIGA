function applyTheme(theme) {
    if (theme === "dark") {
        document.getElementById("theme-stylesheet").setAttribute("href", "css/dark-theme.css");
    } else {
        document.getElementById("theme-stylesheet").setAttribute("href", "css/light-theme.css");
    }
}
