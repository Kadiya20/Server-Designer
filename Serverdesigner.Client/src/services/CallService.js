class CallService {
  constructor() {
    this.calls = [];
    this.counter = 0;
    
  }

  addCall() {
    const name = "NewCall " + (++this.counter);
    const operation = "";
    const templatePath = "";
    
    this.calls.push({
      name: name,
      operation: operation,
      templatePath: templatePath,
    });
  }

  deleteCall(call) {
    console.log(call);
    this.calls = this.calls.filter(c => c.name != call.name); 
    console.log(this.counter);
  }

  cloneCall(call) {
    const clonedCall = {
      name: call.name.replace(/^(NewCall \d+)/, '$1 Clone'),
      operation: call.operation,
      templatePath: call.templatePath
    };
    this.calls.push(clonedCall);
   }
  

  getCalls() {
    return this.calls.map(c => {
      const children = [
        { label: "Name: " + c.name },
        { label: "Operation:" + c.operation },
        { label: "Template path:" + c.templatePath },
      ];
        if (c.azLogin){
          children.push({ label: c.azLogin })
        }
        return { label: c.name, data: c, children };
      });
    }

  toggleAzureAD() {
    this.showAzureAD = !this.showAzureAD
  }

  addAzureAD(call, azLogin) {
    console.log("---- CallService.addAzureAD starts----");
    console.info(this.calls);
  
      const found = this.calls.find(c=> c.name === call.name);
      if (!found) { return false; }
      if (!found.azLogin) {found.azLogin = "AzureAD Login"}

      found.push(azLogin);


      // this.calls[index].children.push({label: "AzureAD Login"});
      
    // console.log(this.calls[currentSelectedNodeIndex].children.Counter);

    // this.calls[currentSelectedNodeIndex].azLogin = "test";
    // console.log(this.calls[currentSelectedNodeIndex].children.Counter);

    // for (c of this.calls) {
    //   console.log("for loop starts");
    //   if ()){
    //     console.info(this.calls[i]);
    //       this.calls[i].children[3].label("AzureAd Login");
    //   }
    // }
  }
}

export default new CallService();
