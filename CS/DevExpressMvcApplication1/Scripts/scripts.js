function OnButtonClick(s, e) {
    callbackPanel.PerformCallback();
}

function OnBeginCallback(s, e) {
    e.customArgs["CategoryID"] = comboBox1.GetValue();
}