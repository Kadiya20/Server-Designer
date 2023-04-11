class CallService {
  constructor() {
    this.calls = [];
    this.Counter = 0;
    this.showAzureAD = false;
  }

  addCall() {
    const name = "NewCall " + (++this.Counter);
    const operation = "";
    const templatePath = "";
    const azLogin = "";
    this.calls.push({
      name: name,
      operation: operation,
      templatePath: templatePath,
      azLogin: azLogin
    });
  }

  deleteCall(call) {
    console.log(call);
    this.calls = this.calls.filter(c => c.name != call.name); 
    console.log(this.Counter);
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
        if (this.showAzureAD && c.addAzureAD){
          children.push({ label: "AzureAD"})
        }
        return { label: c.name, data: c, children };
      });
    }

  toggleAzureAD() {
    this.showAzureAD = !this.showAzureAD
  }

  addAzureAD(call, index) {
    console.log("---- CallService.addAzureAD starts----");
    console.info(this.calls);
    console.log(index);
    this.showAzureAD = true;
    this.calls[index].azLogin = "AzureLogin";
    console.log(this.calls[index].azLogin);
    return true;
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
