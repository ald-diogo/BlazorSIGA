function exibirNotificacao(titulo, corpo) {
    if (Notification.permission === "granted") {
        new Notification(titulo, { body: corpo });
    }
}
