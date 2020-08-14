import React, { useState } from "react";
import {
  Grid,
  Card,
  CardMedia,
  CardContent,
  Typography,
  CircularProgress,
} from "@material-ui/core";
import { makeStyles } from "@material-ui/core/styles";
import { toFirstCharUppercase } from "../Healper";
import mockData from "../mockData";

const useStyles = makeStyles((theme) => ({
  DashboardContainer: {
    paddingTop: "20px",
    paddingLeft: "50px",
    paddingRight: "50px",
  },
  cardMedia: {
    margin: "auto",
  },
  cardContent: {
    textAlign: "center",
  },
}));

export const Dashboard = (props) => {
  const classes = useStyles();
  const { history } = props;
  const [dashboardData, setDashboardData] = useState(mockData);

  const getCard = (catagoryId) => {
    console.log(dashboardData[`${catagoryId}`]);
    console.log("cat " + catagoryId);

    const { id, name } = dashboardData[`${catagoryId}`];
    const sprite = `https://camo.githubusercontent.com/21bfebdd4d567e65f51581a5d31c26adbc885338/687474703a2f2f692e696d6775722e636f6d2f33446b787955682e6a7067`;

    return (
      <Grid item xs={6} sm={4} key={catagoryId}>
        <Card onClick={() => history.push(`/${id}`)}>
          <CardMedia
            className={classes.cardMedia}
            image={sprite}
            style={{ width: "130px", height: "130px" }}
          />
          <CardContent className={classes.cardContent}>
            <Typography>{`${toFirstCharUppercase(name)}`}</Typography>
          </CardContent>
        </Card>
      </Grid>
    );
  };

  return (
    <div>
      {dashboardData ? (
        <Grid container spacing={2} className={classes.DashboardContainer}>
          {Object.keys(dashboardData).map((catagoryId) => getCard(catagoryId))}
        </Grid>
      ) : (
        <CircularProgress />
      )}
    </div>
  );
};
