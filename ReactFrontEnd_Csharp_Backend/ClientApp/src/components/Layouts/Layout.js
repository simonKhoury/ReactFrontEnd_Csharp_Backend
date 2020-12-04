import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { Header } from '../Sections/Header';
import { Footer } from '../Sections/Footer'

export class Layout extends Component {
    static displayName = Layout.name;

    render() {
        return (
            <React.Fragment>
                <Header data={this.props.data}/>
                <Container>
                    {this.props.children}
                </Container>
                <Footer data={this.props.data} />

            </React.Fragment>

        );
    }
}