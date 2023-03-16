class CallService {
  constructor() {
    this.calls = [];
    this.Counter = 0;
  }

  addCall() {
      const name = "NewCall " + (++this.Counter);
      const operation = "Operation :";
      const templatePath = "TemplatePath :";
      this.calls.push({label: name, data: {
        name:name,
        operation :operation,
        templatePath : templatePath,
      } 
    });
  }

  getCalls() {
      return [...this.calls]
  }
}

export default new CallService();
