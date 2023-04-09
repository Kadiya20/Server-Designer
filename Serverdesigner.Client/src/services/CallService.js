class CallService {
  constructor() {
    this.calls = [];
    // this.Inputparameter =[];
    this.Counter = 0;
    this.showInputParameters = false;
  }

  addCall() {
    const name = "NewCall " + (++this.Counter);
    const operation = "";
    const templatePath = "";
    this.calls.push({
      name: name,
      operation: operation,
      templatePath: templatePath,
      InputParameters: []
    });
  }

  deleteCall(call) {
    console.log(call);
    this.calls = this.calls.filter(c => c.name !== call.name);
  }

  cloneCall(call) {
    const clonedCall = {
      name: call.name.replace(/^(NewCall \d+)/, '$1 Clone'),
      operation: call.operation,
      templatePath: call.templatePath,
    };
    this.calls.push(clonedCall);
   }

   addInputParameter(call, inputParameter,show) {
    show = this.showInputParameters;
    if(show)
    {
      const index = this.calls.indexOf(call);
    if (index !== -1) {
      if (!this.calls[index].InputParameters) {
        this.calls[index].InputParameters = [];
      }
      this.calls[index].InputParameters.push(inputParameter);
      this.calls[index].children.push({ label: "InputParameter: " + inputParameter });
    }
  }
  }


  // removeInputParameter(call, inputParameter) {
  //   const index = this.calls.indexOf(call);
  //   if (index !== -1 && this.calls[index].inputParameters) {
  //     this.calls[index].inputParameters = this.calls[index].inputParameters.filter(p => p !== inputParameter);
  //   }
  // }
  

  getCalls() {
    return this.calls.map(c => {
      const children = [
        { label: "Name: " + c.name },
        { label: "Operation: " + c.operation },
        { label: "Template path: " + c.templatePath },
      ];
      if (this.showInputParameters && c.InputParameters) { 
        children.push({ label: "Input Parameters:", children: c.InputParameters.map(p => ({ label: p })) });
      }
      return { label: c.name, data: c, children };
    });
  }
  
}

export default new CallService();
