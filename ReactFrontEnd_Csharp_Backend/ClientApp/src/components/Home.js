import React, { Component } from 'react';
import ReactGA from 'react-ga';
import $, { get } from 'jquery';
import { Layout } from '../components/Layouts/Layout'
import { Header } from '../components/Sections/Header';
import { Footer } from '../components/Sections/Footer'
import { About } from '../components/Sections/About'
import { Contact } from '../components/Sections/Contact';
import { Portfolio } from '../components/Sections/Portfolio';
import { Resume } from '../components/Sections/Resume';

export class Home extends Component {
  static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = {
            foo: 'bar',
            resumeData: {}
            
        };

        ReactGA.initialize('UA-110570651-1');
        ReactGA.pageview(window.location.pathname);

    }

    getResumeData() {

        fetch("api/JsonPackage")
            .then(res => res.json())
            .then(
                (result) => {

                    
                    this.setState({

                        resumeData: result
                 
                    });
                    
                },
                // Note: it's important to handle errors here
                // instead of a catch() block so that we don't swallow
                // exceptions from actual bugs in components.
                (error) => {
                   
                }
            )
    }

    //    $.ajax({
    //        url: 'https://localhost:44350/api/JsonPackage',
    //        dataType: 'json',
    //        cache: false,          
    //        success: function (data) {
    //            this.setState({ resumeData: data });
    //            console.log(data);
    //        }.bind(this),
    //        error: function (xhr, status, err) {
    //            console.log(err);
    //            alert(err);
    //        }
    //    });
    //}

    componentDidMount() {
        this.getResumeData();
    }

    render() {
        return (
            //<div >
            //    <Header data={this.state.resumeData.main} />
            //    <About data={this.state.resumeData.main} />
            //    <Resume data={this.state.resumeData.resume} />
            //    <Portfolio data={this.state.resumeData.portfolio} />
            //    <Contact data={this.state.resumeData.main} />
            //    <Footer data={this.state.resumeData.main} />

            //</div>

            <Layout data={this.state.resumeData.main} >
                
                <About data={this.state.resumeData.main} />
                <Resume data={this.state.resumeData.resume} />
                <Portfolio data={this.state.resumeData.portfolio} />
                <Contact data={this.state.resumeData.main} />
                <div><h1>sadasda</h1></div>

             </Layout>
        );
    }
  }

