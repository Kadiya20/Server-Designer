function AddCall() {
    try {
        var callToAdd = {
            Id: generateGuid(),
            TemplatePath: "",
            ImagePath: "",
            Actions: []
        };
        
        callToAdd.Name = GetCallNameDuplicates(callToAdd.GetTitle(), CallManager.Calls);
        
        CallManager.AddCall(callToAdd);
        
        var newCallJson = JSON.stringify(callToAdd);
        
        var newNode = document.createElement("div");
        newNode.innerHTML = `
            <div class="treeNode">
                <div class="treeNodeText">${callToAdd.Name}</div>
                <div class="treeNodeValue">${newCallJson}</div>
                <img class="treeNodeImage" src="${callToAdd.GetImageUrl()}" alt="Call image" />
            </div>
        `;
        newNode.classList.add("treeNode");
        newNode.addEventListener("click", () => {
            callTreeView.setSelectedNode(newNode);
            CallManager.CurrentCallIndex = callTreeView.Nodes.indexOf(newNode);
        });
        
        var operation = document.createElement("div");
        operation.classList.add("treeNode");
        operation.innerHTML = callToAdd.GetPropertyTitle(nameof(callToAdd.Operation));
        
        var templatePath = document.createElement("div");
        templatePath.classList.add("treeNode");
        templatePath.innerHTML = callToAdd.GetPropertyTitle(nameof(callToAdd.TemplatePath));
        
        var name = document.createElement("div");
        name.classList.add("treeNode");
        name.innerHTML = `${callToAdd.GetPropertyTitle(nameof(callToAdd.Name))} : ${callToAdd.Name}`;
        
        newNode.appendChild(operation);
        newNode.appendChild(templatePath);
        newNode.appendChild(name);
        
        callTreeView.appendChild(newNode);
        newNode.click();
        _madeChange = true;
        GrayOut();
        
    }
    catch (exc) {
        alert("messageBox");
    }
}

function generateGuid() {
    return "xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx".replace(/[xy]/g, function (c) {
        var r = Math.random() * 16 | 0,
            v = c == "x" ? r : (r & 0x3 | 0x8);
        return v.toString(16);
    });
}
