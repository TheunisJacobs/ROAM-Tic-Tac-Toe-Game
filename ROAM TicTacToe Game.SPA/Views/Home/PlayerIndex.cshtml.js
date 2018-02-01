import Vue from "vue";
import http from 'axios';

document.addEventListener('DOMContentLoaded', function (event) {
    let view = new Vue({
        el: document.getElementById('view'),
        mounted: function () { },
        data: {
            firstName: "",
            lastName: "",
            address:"",
            message: "Message from vue"
        },
        methods:
        {
            addEmployee: function () {
                try {
                    var url = '/Home/EmployeeIndex/';
                    var data = {
                        "firstName": this.firstName,
                        "lastName": this.lastName
                    };
                    var self = this;
                    http.post(url, data)
                        .then(function (response) {
                            console.log("successfully added!");
                        })
                        .catch(function (error) {
                            console.log(error);
                        });
                } catch (ex) {
                    console.log(ex);
                }

               return false;
            },
        }
    });
});