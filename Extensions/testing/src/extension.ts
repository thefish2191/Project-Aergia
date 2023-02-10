import * as vscode from 'vscode';

export function activate(context: vscode.ExtensionContext) {
    console.log('Congratulations, your extension "testing" is now active!');
    let disposable = vscode.commands.registerCommand('testing.helloWorld', () => {
        // The code you place here will be executed every time your command is executed
        // Display a message box to the user
        vscode.window.showInformationMessage('Hello VS Code!');
    });
    let newMethod = vscode.commands.registerCommand('testing.showTime', () => {
        // some code h
        let date = new Date().toLocaleString();
        vscode.window.showInformationMessage(date);
    });
    context.subscriptions.push(disposable, newMethod);
}

// This method is called when your extension is deactivated
export function deactivate() { }
