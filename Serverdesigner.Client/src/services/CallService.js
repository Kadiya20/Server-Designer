class CallService {
  constructor() {
    this.calls = [];
    this.Counter = 0;
  }

  addCall() {
    const name = "NewCall " + (++this.Counter);
    const operation = "";
    const templatePath = "";
    this.calls.push({
      name: name,
      operation: operation,
      templatePath: templatePath
    });
  }

  deleteCall(call) {
    console.log(call);
    this.calls = this.calls.filter(c => c.name != call.name);
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
    return this.calls.map(c => ({
      label: c.name, data: c, children: [
        { label: "Name: " + c.name },
        { label: "Operation:" + c.operation },
        { label: "Template path:" + c.templatePath },
      ]
    }));
  }
}

export default new CallService();
