class CallService {
  constructor() {
    this.calls = [];
    this.Counter = 0;
  }

  addCall() {
      const name = "NewCall " + (++this.Counter);
      this.calls.push({label: name, data: {name:name}});
  }

  getCalls() {
      return [...this.calls]
  }
}

export default new CallService();
